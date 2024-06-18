import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MetricsBComponent } from './metrics-b.component';

describe('MetricsBComponent', () => {
  let component: MetricsBComponent;
  let fixture: ComponentFixture<MetricsBComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MetricsBComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MetricsBComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
