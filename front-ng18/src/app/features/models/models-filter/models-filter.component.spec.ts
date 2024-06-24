import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModelsFilterComponent } from './models-filter.component';

describe('ModelsFilterComponent', () => {
  let component: ModelsFilterComponent;
  let fixture: ComponentFixture<ModelsFilterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ModelsFilterComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ModelsFilterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
