import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LayoutFullComponent } from './layout-full.component';

describe('LayoutFullComponent', () => {
  let component: LayoutFullComponent;
  let fixture: ComponentFixture<LayoutFullComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [LayoutFullComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LayoutFullComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
